﻿using AutoMapper;

using CA.Domain.DTO;
using CA.Domain.Custom;
using CA.Domain.Entities;
using CA.Application.Queries;

namespace CA.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            /* Artículos. */
            CreateMap<Article, ArticleDTO>().ReverseMap();
            CreateMap<CreateArticleDTO, Article>().ReverseMap();
            CreateMap<CreateArticleDTO, ArticleDTO>().ReverseMap();
            CreateMap<UpdateArticleDTO, Article>().ReverseMap();
            CreateMap<UpdateArticleDTO, ArticleDTO>().ReverseMap();
            CreateMap<DeleteArticleDTO, Article>().ReverseMap();
            CreateMap<DeleteArticleDTO, ArticleDTO>().ReverseMap();

            /* Marcas de artículo. */
            CreateMap<BrandDTO, Brand>().ReverseMap();
            CreateMap<CreateBrandDTO, Brand>().ReverseMap();
            CreateMap<CreateBrandDTO, BrandDTO>().ReverseMap();
            CreateMap<UpdateBrandDTO, Brand>().ReverseMap();
            CreateMap<UpdateBrandDTO, BrandDTO>().ReverseMap();
            CreateMap<DeleteBrandDTO, Brand>().ReverseMap();
            CreateMap<DeleteBrandDTO, BrandDTO>().ReverseMap();

            /* Codigos de espacios de nombres. */
            CreateMap<CodeNameSpaceDTO, CodeNamespace>().ReverseMap();
            CreateMap<CreateCodeNameSpaceDTO, CodeNamespace>().ReverseMap();
            CreateMap<CreateCodeNameSpaceDTO, CodeNameSpaceDTO>().ReverseMap();
            CreateMap<UpdateCodeNameSpaceDTO, CodeNamespace>().ReverseMap();
            CreateMap<UpdateCodeNameSpaceDTO, CodeNameSpaceDTO>().ReverseMap();
            CreateMap<DeleteCodeNameSpaceDTO, CodeNamespace>().ReverseMap();
            CreateMap<DeleteCodeNameSpaceDTO, CodeNameSpaceDTO>().ReverseMap();

            /* Códigos de valores. */
            CreateMap<CodeValueDTO, CodeValue>().ReverseMap();
            CreateMap<CreateCodeValueDTO, CodeValue>().ReverseMap();
            CreateMap<CreateCodeValueDTO, CodeValueDTO>().ReverseMap();
            CreateMap<UpdateCodeValueDTO, CodeValue>().ReverseMap();
            CreateMap<UpdateCodeValueDTO, CodeValueDTO>().ReverseMap();
            CreateMap<DeleteCodeValueDTO, CodeValue>().ReverseMap();
            CreateMap<DeleteCodeValueDTO, CodeValueDTO>().ReverseMap();

            /* Catálogo de países del mundo. */
            CreateMap<CountryDTO, Country>().ReverseMap();

            /* Catálogo de detalle de países del mundo (códigos postales). */
            CreateMap<CountryDetailDTO, CountryDetail>().ReverseMap();

            /* Clientes. */
            CreateMap<CustomerDTO, Customer>().ReverseMap();
            CreateMap<CreateCustomerDTO, Customer>().ReverseMap();
            CreateMap<CreateCustomerDTO, CustomerDTO>().ReverseMap();
            CreateMap<UpdateCustomerDTO, Customer>().ReverseMap();
            CreateMap<UpdateCustomerDTO, CustomerDTO>().ReverseMap();
            CreateMap<DeleteCustomerDTO, Customer>().ReverseMap();
            CreateMap<DeleteCustomerDTO, CustomerDTO>().ReverseMap();

            /* Categorías. */
            CreateMap<CategoryDTO, MenuCategory>().ReverseMap();
            CreateMap<MenuDTO, MenuSystem>().ReverseMap();

            /* Movimientos de inventario e inventario de artículos. */
            CreateMap<StockArticleDTO, StockArticle>().ReverseMap();
            CreateMap<MovementArticleDTO, MovementArticle>().ReverseMap();

            /* Sucursales. */
            CreateMap<Store, StoreDTO>().ReverseMap();
            CreateMap<CreateStoreDTO, Store>().ReverseMap();
            CreateMap<CreateStoreDTO, StoreDTO>().ReverseMap();
            CreateMap<UpdateStoreDTO, Store>().ReverseMap();
            CreateMap<UpdateStoreDTO, StoreDTO>().ReverseMap();
            CreateMap<DeleteStoreDTO, Store>().ReverseMap();
            CreateMap<DeleteStoreDTO, StoreDTO>().ReverseMap();

            /* Proveedores. */
            CreateMap<SupplierDTO, Supplier>().ReverseMap();
            CreateMap<CreateSupplierDTO, Supplier>().ReverseMap();
            CreateMap<CreateSupplierDTO, SupplierDTO>().ReverseMap();
            CreateMap<UpdateSupplierDTO, Supplier>().ReverseMap();
            CreateMap<UpdateSupplierDTO, SupplierDTO>().ReverseMap();
            CreateMap<DeleteSupplierDTO, Supplier>().ReverseMap();
            CreateMap<DeleteSupplierDTO, SupplierDTO>().ReverseMap();

            /* Órdenes de compra a proveedor. */
            CreateMap<Purchase, PurchaseDTO>().ForMember(s => s.PurchaseDetails, c => c.MapFrom(m => m.PurchaseDetails)).ReverseMap();
            CreateMap<PurchaseDetailDTO, PurchaseDetail>().ReverseMap();
            CreateMap<CreatePurchaseDTO, Purchase>().ReverseMap();
            CreateMap<CreatePurchaseDTO, PurchaseDTO>().ReverseMap();
            CreateMap<CreatePurchaseDetailDTO, PurchaseDetail>().ReverseMap();
            CreateMap<CreatePurchaseDetailDTO, PurchaseDetailDTO>().ReverseMap();

            /* Asignación de artículos a sucursal. */
            CreateMap<Assignment, AssignmentDTO>().ForMember(s => s.AssignmentDetails, c => c.MapFrom(m => m.AssignmentDetails)).ReverseMap();
            CreateMap<AssignmentDetailDTO, AssignmentDetail>().ReverseMap();
            CreateMap<CreateAssignmentDTO, Assignment>().ReverseMap();
            CreateMap<CreateAssignmentDTO, AssignmentDTO>().ReverseMap();
            CreateMap<CreateAssignmentDetailDTO, AssignmentDetail>().ReverseMap();
            CreateMap<CreateAssignmentDetailDTO, AssignmentDetailDTO>().ReverseMap();

            /* Compra del cliente. */
            CreateMap<Order, OrderDTO>().ForMember(s => s.OrderDetails, c => c.MapFrom(m => m.OrderDetails)).ReverseMap();
            CreateMap<OrderDetailDTO, OrderDetail>().ReverseMap();
            CreateMap<CreateSaleDTO, Order>().ReverseMap();
            CreateMap<CreateSaleDTO, OrderDTO>().ReverseMap();
            CreateMap<CreateSaleDetailDTO, OrderDetail>().ReverseMap();
            CreateMap<CreateSaleDetailDTO, OrderDetailDTO>().ReverseMap();

            /* Usuarios (Pendiente...). */

            /* Mapping queries and parameters. */
            CreateMap<GetAllArticleQuery, GetAllArticleParameter>().ReverseMap();
            CreateMap<GetAllBrandQuery, GetAllBrandParameter>().ReverseMap();
            CreateMap<GetAllCategoryQuery, GetAllCategoryParameter>().ReverseMap();
            CreateMap<GetAllCodeNameSpaceQuery, GetAllCodeNameSpaceParameter>().ReverseMap();
            CreateMap<GetAllCodeValueQuery, GetAllCodeValueParameter>().ReverseMap();
            CreateMap<GetAllCountryDetailQuery, GetAllCountryDetailParameter>().ReverseMap();
            CreateMap<GetAllCountryQuery, GetAllCountryParameter>().ReverseMap();
            CreateMap<GetAllCustomerQuery, GetAllCustomerParameter>().ReverseMap();
            CreateMap<GetAllMenuQuery, GetAllMenuParameter>().ReverseMap();
            CreateMap<GetAllMovementArticleQuery, GetAllMovementArticleParameter>().ReverseMap();
            CreateMap<GetAllStockArticleQuery, GetAllStockArticleParameter>().ReverseMap();
            CreateMap<GetAllStoreQuery, GetAllStoreParameter>().ReverseMap();
            CreateMap<GetAllSupplierQuery, GetAllSupplierParameter>().ReverseMap();
            CreateMap<GetAllPurchaseQuery, GetAllPurchaseParameter>().ReverseMap();
            CreateMap<GetAllAssignmentQuery, GetAllAssignmentParameter>().ReverseMap();
            CreateMap<GetAllSaleOrderQuery, GetAllSaleOrderParameter>().ReverseMap();

            /* Mapping complex objects. */
            CreateMap(typeof(PagedList<>), typeof(MetaData<>)).ConvertUsing(typeof(ConverterPaging<,>));
        }
    }
}
