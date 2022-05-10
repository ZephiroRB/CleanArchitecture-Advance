﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CA.Domain.Entities.Base;
using CA.Domain.Interfaces.Management;

namespace CA.Infrastructure.Common.Helpers
{
    public class DataShapeHelper<T> : IDataShapeHelper<T>
    {
        public PropertyInfo[] Properties { get; set; }

        public DataShapeHelper()
        {
            Properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }
        public ShapedEntityDTO ShapeData(T entity, string fieldsString) =>
            FetchDataForEntity(entity, GetRequiredProperties(fieldsString));
        public IEnumerable<ShapedEntityDTO> ShapeData(IEnumerable<T> entities, string fieldsString) =>
            FetchData(entities, GetRequiredProperties(fieldsString));
        public async Task<IEnumerable<ShapedEntityDTO>> ShapeDataAsync(IEnumerable<T> entities, string fieldsString) =>
            await Task.Run(() => FetchData(entities, GetRequiredProperties(fieldsString)));
        private IEnumerable<PropertyInfo> GetRequiredProperties(string fieldsString)
        {
            var requiredProperties = new List<PropertyInfo>();

            if (!string.IsNullOrWhiteSpace(fieldsString))
            {
                var fields = fieldsString.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach (var field in fields)
                {
                    var property = Properties.FirstOrDefault(pi => pi.Name.Equals(field.Trim(), StringComparison.InvariantCultureIgnoreCase));

                    if (property == null)
                        continue;

                    requiredProperties.Add(property);
                }
            }
            else
            {
                requiredProperties = Properties.ToList();
            }

            return requiredProperties;
        }
        private IEnumerable<ShapedEntityDTO> FetchData(IEnumerable<T> entities, IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapedData = new List<ShapedEntityDTO>();

            foreach (var entity in entities)
            {
                var shapedObject = FetchDataForEntity(entity, requiredProperties);
                shapedData.Add(shapedObject);
            }

            return shapedData;
        }
        private ShapedEntityDTO FetchDataForEntity(T entity, IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapedObject = new ShapedEntityDTO();

            foreach (var property in requiredProperties)
            {
                var objectPropertyValue = property.GetValue(entity);
                if (objectPropertyValue != null)
                    shapedObject.TryAdd(property.Name, objectPropertyValue);
            }

            return shapedObject;
        }
    }
}
