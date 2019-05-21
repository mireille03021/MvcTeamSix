using ANVI_Mvc.Models;

namespace ANVI_Mvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ANVI_Mvc.Models.AnviModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ANVI_Mvc.Models.AnviModel context)
        {
            context.Categories.AddOrUpdate(
                x => x.CategoryID,
                new Category() { CategoryID = 1, CategoryName = "Bracelets" },
                new Category() { CategoryID = 2, CategoryName = "EarRings" },
                new Category() { CategoryID = 3, CategoryName = "Necklaces" },
                new Category() { CategoryID = 4, CategoryName = "Rings" }
            );
            context.Colors.AddOrUpdate(
                x => x.ColorID,
                new Color() { ColorID = 1, ColorName = "18k-Gold" }
            );
            context.Sizes.AddOrUpdate(
                x => x.SizeID,
                new Size() { SizeID = 1, SizeTitle = "鏈長", SizeContext = "14" },
                new Size() { SizeID = 2, SizeTitle = "鏈長", SizeContext = "15.5" },
                new Size() { SizeID = 3, SizeTitle = "鏈長", SizeContext = "17" },
                new Size() { SizeID = 4, SizeTitle = "尺寸", SizeContext = "單一尺寸" },
                new Size() { SizeID = 5, SizeTitle = "鏈長", SizeContext = "42" },
                new Size() { SizeID = 6, SizeTitle = "鏈長", SizeContext = "46" },
                new Size() { SizeID = 7, SizeTitle = "尺寸", SizeContext = "2" },
                new Size() { SizeID = 8, SizeTitle = "尺寸", SizeContext = "3" },
                new Size() { SizeID = 9, SizeTitle = "尺寸", SizeContext = "5" },
                new Size() { SizeID = 10, SizeTitle = "尺寸", SizeContext = "6" },
                new Size() { SizeID = 11, SizeTitle = "尺寸", SizeContext = "7" }
            );
            context.Products.AddOrUpdate(
                x => x.ProductID,
                new Product() { ProductID = 1, ProductName = "細珠純銀手鍊", CategoryID = 1, UnitPrice = 1250 },
                new Product() { ProductID = 2, ProductName = "鋯石純銀耳扣", CategoryID = 2, UnitPrice = 1580 },
                new Product() { ProductID = 3, ProductName = "細珠層次純銀項鍊", CategoryID = 3, UnitPrice = 2250 },
                new Product() { ProductID = 4, ProductName = "八芒星圖章純銀尾戒", CategoryID = 4, UnitPrice = 1700 },
                new Product() { ProductID = 5, ProductName = "鋯石C字戒指", CategoryID = 4, UnitPrice = 900 }
            );
            context.DesSubTitles.AddOrUpdate(
                x => x.DSTID,
                new DesSubTitle() { DSTID = 1, ProductID = 1, SubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品，擁有絕佳搭配性與優雅迷人韻味" },
                new DesSubTitle() { DSTID = 2, ProductID = 2, SubTitle = "潮流型女絕不能錯過的個性耳扣，無須耳洞直接掛上耳骨，為雙耳添上時髦魅力。" },
                new DesSubTitle() { DSTID = 3, ProductID = 3, SubTitle = "多層次項鍊帶有高調華麗姿態，簡約細鍊與細小圓珠卻個性、時髦還帶有優雅性感，各種場合與穿搭都派得上場！" },
                new DesSubTitle() { DSTID = 4, ProductID = 4, SubTitle = "潮流型女絕不能錯過的圖章尾戒，簡約大方個性十足，與其他款式做多層次穿搭，帶來新舊元素的完美結合。" },
                new DesSubTitle() { DSTID = 5, ProductID = 5, SubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品，擁有絕佳搭配性與優雅迷人韻味。" }
            );
            context.DesDetails.AddOrUpdate(
                x => x.DDID,
                new DesDetail() { DDID = 1, ProductID = 1, Detail = "材質：純銀" },
                new DesDetail() { DDID = 2, ProductID = 1, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 3, ProductID = 1, Detail = "鏈長：14/15.5/17 cm（可調整）" },
                new DesDetail() { DDID = 4, ProductID = 1, Detail = "材質：純銀、2mm手工精鑲鋯石" },
                new DesDetail() { DDID = 5, ProductID = 2, Detail = "材質：純銀、2mm手工精鑲鋯石" },
                new DesDetail() { DDID = 6, ProductID = 2, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 7, ProductID = 2, Detail = "尺寸：單一尺寸" },
                new DesDetail() { DDID = 8, ProductID = 3, Detail = "材質：純銀" },
                new DesDetail() { DDID = 9, ProductID = 3, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 10, ProductID = 3, Detail = "鏈長：42/46 cm（可調整）" },
                new DesDetail() { DDID = 11, ProductID = 4, Detail = "純銀材質" },
                new DesDetail() { DDID = 12, ProductID = 4, Detail = "18k金層" },
                new DesDetail() { DDID = 13, ProductID = 4, Detail = "1mm 手工精鑲鋯石" },
                new DesDetail() { DDID = 14, ProductID = 4, Detail = "尺寸：2 / 3" },
                new DesDetail() { DDID = 15, ProductID = 5, Detail = "材質：純銀、1mm手工精鑲鋯石" },
                new DesDetail() { DDID = 16, ProductID = 5, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 17, ProductID = 5, Detail = "尺寸：5 / 6 / 7" }
            );
            context.ProductDetails.AddOrUpdate(
                x => x.PDID,
                new ProductDetail() { PDID = "1-1", ProductID = 1, Stock = 10, SizeID = 1, ColorID = 1 },
                new ProductDetail() { PDID = "1-2", ProductID = 1, Stock = 10, SizeID = 2, ColorID = 1 },
                new ProductDetail() { PDID = "1-3", ProductID = 1, Stock = 10, SizeID = 3, ColorID = 1 },
                new ProductDetail() { PDID = "2-1", ProductID = 2, Stock = 10, SizeID = 4, ColorID = 1 },
                new ProductDetail() { PDID = "3-1", ProductID = 3, Stock = 5, SizeID = 5, ColorID = 1 },
                new ProductDetail() { PDID = "3-2", ProductID = 3, Stock = 5, SizeID = 6, ColorID = 1 },
                new ProductDetail() { PDID = "4-1", ProductID = 4, Stock = 3, SizeID = 7, ColorID = 1 },
                new ProductDetail() { PDID = "4-2", ProductID = 4, Stock = 3, SizeID = 8, ColorID = 1 },
                new ProductDetail() { PDID = "5-1", ProductID = 5, Stock = 4, SizeID = 9, ColorID = 1 },
                new ProductDetail() { PDID = "5-2", ProductID = 5, Stock = 10, SizeID = 10, ColorID = 1 },
                new ProductDetail() { PDID = "5-3", ProductID = 5, Stock = 3, SizeID = 11, ColorID = 1 }
            );
            context.Images.AddOrUpdate(
                x => x.ImgID,
                new Image() { ImgID = 1, PDID = "1-1", ImgName = "B19401_400x.jpg" },
                new Image() { ImgID = 2, PDID = "1-1", ImgName = "3_ebcf859e-215d-4b14-8a01-6ad2535e40a2_600x.jpg" },
                new Image() { ImgID = 3, PDID = "1-1", ImgName = "4_970e215a-18c2-4afb-826f-0c5b3835757b_900x.jpg" },
                new Image() { ImgID = 4, PDID = "2-1", ImgName = "E19402G-1_900x.jpg" },
                new Image() { ImgID = 5, PDID = "2-1", ImgName = "G3_a94660c7-92de-46e5-966d-617f55f9d59e_900x.jpg" },
                new Image() { ImgID = 6, PDID = "3-1", ImgName = "N19402G_900x.jpg" },
                new Image() { ImgID = 7, PDID = "3-1", ImgName = "3_3_2e459b5c-083d-4682-9861-2718a9292092_900x.jpg" },
                new Image() { ImgID = 8, PDID = "4-1", ImgName = "R19401_900x.jpg" },
                new Image() { ImgID = 9, PDID = "4-1", ImgName = "3_e011466f-942c-4c87-87df-cfaa3f0b17ee_900x.jpg" },
                new Image() { ImgID = 10, PDID = "5-1", ImgName = "R19402-2_900x.jpg" },
                new Image() { ImgID = 11, PDID = "5-1", ImgName = "c_2_7563982b-8284-4637-a92b-a3763e0256d3_900x.jpg" },
                new Image() { ImgID = 12, PDID = "5-1", ImgName = "c_bf10070a-2fe0-4aca-8aaa-b4af42889cdf_900x.jpg" },
                new Image() { ImgID = 13, PDID = "5-1", ImgName = "C_3_ef589395-f96a-4215-8b61-841d4fc579cf_900x.jpg" },
                new Image() { ImgID = 14, PDID = "5-1", ImgName = "c_2_7563982b-8284-4637-a92b-a3763e0256d3_900x.jpg" }
            );
            context.Customers.AddOrUpdate(
                x => x.CustomerID,
                new Customer() { CustomerID = 1, CustomerName = "Anvi", Phone = "0900-000-123", Country = "Taiwan", City = "Taipei", Email = "anvi@gmail.com", Address = "5F., Aly. 4, Ln. 2, Dalong St., Datong Dist., Taipei City", ZipCode = "103" },
                new Customer() { CustomerID = 2, CustomerName = "中華大學", Phone = "03-563-1988", Country = "Taiwan", City = "新竹", Email = "chu@chu.edu.tw", Address = "新竹市香山區五福路二段707號", ZipCode = "300" }
            );
            context.Shippers.AddOrUpdate(
                x => x.ShipperID,
                new Shipper() { ShipperID = 1, ShippName = "黑貓", Phone = "02-321-5523" },
                new Shipper() { ShipperID = 2, ShippName = "郵局", Phone = "02-123-5529" }
            );
            context.Orders.AddOrUpdate(
                x => x.OrderID,
                new Order() { OrderID = 1, CustomerID = 1, ShippingID = 1, RecipientName = "Hu", RecipientAddressee = "桃園市中壢區", RecipientZipCod = "320", RecipientCity = "桃園", RecipientPhone = "0967-890-000", Payment = "超商取貨", OrderDate = new DateTime(2019, 03, 20, 0, 12, 10, 927), Remaeks = "一天內出貨", ShipDate = new DateTime(2019, 03, 21, 0, 12, 10, 927) }
            );
            context.OrderDetails.AddOrUpdate(
                x => x.OrderID,
                new OrderDetail() { OrderID = 1, ProductID = 4, Price = 1700, Quantity = 1 }
            );
        }
    }
}
