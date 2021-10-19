using Microsoft.EntityFrameworkCore.Migrations;

namespace ordering.products.api.Migrations
{
    public partial class PopulateProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var StoredProcedure = @"CREATE PROCEDURE PopulateProducts
                   
                AS
                BEGIN
                    SET NOCOUNT ON;
                   /****** Script for SelectTopNRows command from SSMS  ******/
INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Lenovo IdealPad'
      ,'Intel Celeron N4020 2.8Ghz
4GB Memory
64GB EMMC
Integrated Intel UHD Graphics
14- inch HD Screen
Micro SD Card reader
Windows 10 Home
3 Year warranty upon registration'
      ,4999
      ,'Imageurl'
      ,50) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('HP Pavilion 15x360 core i7'
      ,'Windows 11 Home
15.6 FHD
16GB and 512GB SSD Storage
Intel Core i7 1165G7 Processor
Intel Iris Xe Graphics
HP Wide Vision 720p HD Webcam
Realtek Wi-Fi 6 & Bluetooth 5.2 Combo
1 microSD media card reader'
      ,19999
      ,'Imageurl'
      ,10) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Acer Aspire 1 Pentium N5030'
      ,'Windows 10 Home
14-Inch HD Display
4GB RAM and 128GB eMMC Storage
Intel Pentium Silver N5030 Processor
Intel UHD Graphics
180 Degree Lay Flat
Precision Touch Pad'
      ,5499
      ,'Imageurl'
      ,15) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('HP Pavilion Gaming i5 '
      ,'Upgradeable to Windows 11 Home
Intel® Core™ i5-10300H Processor
Memory: 8GB RAM
Storage: 256GB NVMe™ M.2 SSD + 1TB
Intel® UHD Graphics
Nvidia Geforce GTX1650 4GB Graphics
15.6 FHD Backlit Display'
      ,5499
      ,'Imageurl'
      ,15) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Acer Nitro 5 i5'
      ,'Upgradeable to Windows 11 Home
15.6-Inch FHD IPS 144Hz Display
8GB RAM and 1TB HDD Storage
Intel Core i5 10300H Processor
NVIDIA GeForce GTX 1650
Acer NitroSense & CoolBoost
Immersive Gaming Audio'
      ,14999
      ,'Imageurl'
      ,10) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Acer Edu Spin 1 Celeron'
      ,'Windows 10 Home
11.6-Inch HD Touch Display
4GB RAM and 64GB eMMC Storage
Intel Celeron N4000 Processor
Micro SD Expandable Storage
Intel UHD Graphics 600
360 Degree Convertible'
      ,5999
      ,'Imageurl'
      ,8) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Connex Swiftbook Pro Celeron'
      ,'Windows 10 Home
14-Inch HD Display
Intel Celeron N3350 Processor
4GB RAM and 64GB eMMC Storage
Micro SD Expandable Storage Slot
Built-In Webcam, Wi-Fi and Bluetooth'
      ,3999
      ,'Imageurl'
      ,8) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Mecer MyLife 14 Z140C Xpress Celeron'
      ,'Windows 10 Pro
14-Inch HD Display
4GB RAM and 64GB eMMC Storage
Intel Celeron N3350 Processor
Integrated Intel HD Graphics
Up to 8 Hours Battery Life
Built in Camera'
      ,4499
      ,'Imageurl'
      ,15) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('HP Pavilion Gaming i5 '
      ,'Upgradeable to Windows 11 Home
Intel® Core™ i5-10300H Processor
Memory: 8GB RAM
Storage: 256GB NVMe™ M.2 SSD + 1TB
Intel® UHD Graphics
Nvidia Geforce GTX1650 4GB Graphics
15.6 FHD Backlit Display'
      ,5499
      ,'Imageurl'
      ,15) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Mecer MyLife 14 Z140C Xpress Celeron'
      ,'Windows 10 Pro
14-Inch HD Display
4GB RAM and 64GB eMMC Storage
Intel Celeron N3350 Processor
Integrated Intel HD Graphics
Up to 8 Hours Battery Life
Built in Camera'
      ,14999
      ,'Imageurl'
      ,10) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Lenovo LONGPAD'
      ,'Intel Celeron N4020 2.8Ghz
4GB Memory
64GB EMMC
Integrated Intel UHD Graphics
14- inch HD Screen
Micro SD Card reader
Windows 10 Home
3 Year warranty upon registration'
      ,4999
      ,'Imageurl'
      ,50) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('HP Pavilion i3'
      ,'Windows 11 Home
15.6 FHD
16GB and 512GB SSD Storage
Intel Core i7 1165G7 Processor
Intel Iris Xe Graphics
HP Wide Vision 720p HD Webcam
Realtek Wi-Fi 6 & Bluetooth 5.2 Combo
1 microSD media card reader'
      ,19999
      ,'Imageurl'
      ,10) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Gold Acer'
      ,'Windows 10 Home
14-Inch HD Display
4GB RAM and 128GB eMMC Storage
Intel Pentium Silver N5030 Processor
Intel UHD Graphics
180 Degree Lay Flat
Precision Touch Pad'
      ,5499
      ,'Imageurl'
      ,15) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('HD Gamming LG'
      ,'Upgradeable to Windows 11 Home
Intel® Core™ i5-10300H Processor
Memory: 8GB RAM
Storage: 256GB NVMe™ M.2 SSD + 1TB
Intel® UHD Graphics
Nvidia Geforce GTX1650 4GB Graphics
15.6 FHD Backlit Display'
      ,5499
      ,'Imageurl'
      ,15) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('gistro 9'
      ,'Upgradeable to Windows 11 Home
15.6-Inch FHD IPS 144Hz Display
8GB RAM and 1TB HDD Storage
Intel Core i5 10300H Processor
NVIDIA GeForce GTX 1650
Acer NitroSense & CoolBoost
Immersive Gaming Audio'
      ,14999
      ,'Imageurl'
      ,10) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Acer Edukana'
      ,'Windows 10 Home
11.6-Inch HD Touch Display
4GB RAM and 64GB eMMC Storage
Intel Celeron N4000 Processor
Micro SD Expandable Storage
Intel UHD Graphics 600
360 Degree Convertible'
      ,5999
      ,'Imageurl'
      ,8) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('SoftbookCeleron'
      ,'Windows 10 Home
14-Inch HD Display
Intel Celeron N3350 Processor
4GB RAM and 64GB eMMC Storage
Micro SD Expandable Storage Slot
Built-In Webcam, Wi-Fi and Bluetooth'
      ,3999
      ,'Imageurl'
      ,8) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('LG recovery'
      ,'Windows 10 Pro
14-Inch HD Display
4GB RAM and 64GB eMMC Storage
Intel Celeron N3350 Processor
Integrated Intel HD Graphics
Up to 8 Hours Battery Life
Built in Camera'
      ,4499
      ,'Imageurl'
      ,15) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Samsung'
      ,'Upgradeable to Windows 11 Home
Intel® Core™ i5-10300H Processor
Memory: 8GB RAM
Storage: 256GB NVMe™ M.2 SSD + 1TB
Intel® UHD Graphics
Nvidia Geforce GTX1650 4GB Graphics
15.6 FHD Backlit Display'
      ,5499
      ,'Imageurl'
      ,15) 

INSERT INTO [OrderingApp].[dbo].[Products] (
       [Title]
      ,[Description]
      ,[Price]
      ,[Image]
      ,[Quantity])

VALUES ('Lap toppy'
      ,'Windows 10 Pro
14-Inch HD Display
4GB RAM and 64GB eMMC Storage
Intel Celeron N3350 Processor
Integrated Intel HD Graphics
Up to 8 Hours Battery Life
Built in Camera'
      ,14999
      ,'Imageurl'
      ,10) 


                END";

            migrationBuilder.Sql(StoredProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
