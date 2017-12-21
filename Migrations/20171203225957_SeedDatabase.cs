using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace web.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
migrationBuilder.Sql("INSERT INTO product (Id,ProductName,Price,Description,ImageUrl,Type) VALUES ('1','HP - ENVY x360 2-in-1 15.6', '$849.99','Touch-Screen Laptop  Intel Core i5 - 12GB Memory - 1TB Hard Drive - Natural Silver.Take handwritten virtual notes with this 15.6-inch HP ENVY convertible laptop. Its Full HD touch screen display is pen-enabled and supports Windows Ink applications and you can multitask smoothly thanks to its Intel Core i5 processor and 12GB of RAM. This HP ENVY convertible laptop has 1TB of storage, and its Windows Hello system provides secure accessibility.','../../assets/image/1.jpg','Laptop')");
migrationBuilder.Sql("INSERT INTO product (Id,ProductName,Price,Description,ImageUrl,Type) VALUES ('2','Dell - Inspiron 15.6 ','$399.99','Touch-Screen Laptop-Intel Core i3 - 6GB Memory - 1TB Hard Drive - Black Inspiron notebook computer.The 7th-generation Intel Core i3 processor is paired with 6GB of DDR4 RAM for lag-free multitasking, and the 1TB hard drive stores your important files securely. This Dell Inspiron notebook computer has two USB 3.0 ports for fast data transfers.','../../assets/image/2.jpg','Laptop')");      
migrationBuilder.Sql("INSERT INTO product (Id,ProductName,Price,Description,ImageUrl,Type) VALUES ('3','Apple - MacBook Pro®','$1,299.99','13 Display - Intel Core i5 - 8 GB Memory - 128GB Flash Storage (Latest Model) - Space Gray.The new MacBook Pro is razor-thin, featherlight, and now even faster and more powerful than before. It has the brightest, most colorful Mac notebook display. And it features up to 10 hours of battery life.* It’s a notebook built for the work you do every day. Ready to go anywhere a great idea takes you.','../../assets/image/3.jpg','Laptop')");
migrationBuilder.Sql("INSERT INTO product (Id,ProductName,Price,Description,ImageUrl,Type) VALUES ('4','Lenovo - 15.6 Laptop ','$219.99','AMD A6-Series - 4GB Memory - 500GB Hard Drive - Black.Lenovo 110-15ACL Laptop: Enjoy productivity anywhere with this 15.6-inch Lenovo Ideapad laptop. Its 500GB of storage holds plenty of large applications and documents, and its built-in optical drive lets you read and write digital files. The quad-core AMD A6 processor and 4GB of RAM let this Lenovo Ideapad laptop run Windows 10 smoothly.','../../assets/image/4.jpg','Laptop')");
migrationBuilder.Sql("INSERT INTO product (Id,ProductName,Price,Description,ImageUrl,Type) VALUES ('5','LG Phoenix 3 ','$49.99','4G LTE with 16GB Memory Prepaid Cell Phone - Black .Stay connected with this LG Phoenix 3 for AT&T Prepaid. The 5-inch screen provides room for scrolling and a sizable viewing area for watching videos, and the 16GB storage capacity lets you download plenty of apps. This LG Phoenix 3 has both front and rear cameras for enhanced usability and Auto Shot face detection for automatic selfies.','../../assets/image/5.jpg','Cell Phone')");
migrationBuilder.Sql("INSERT INTO product (Id,ProductName,Price,Description,ImageUrl,Type) VALUES ('6',' Samsung Galaxy J3 ','$79.99','Emerge 4G LTE with 16GB Memory Cell Phone - Silver.The Samsung Galaxy J3 Emerge smartphone offers solid core fundamental experiences at an affordable price point. A brilliant 5 HD touchscreen display and the latest Android 6.0 Marshmallow OS makes browsing and emailing a breeze. A powerful quad core CPU which provides improved power consumption and processing speed to help you get things done quicker and more efficient. Packed with essentials, the Samsung Galaxy J3 Emerge gives you the best of the basics.','../../assets/image/6.jpg','Cell Phone')");                  
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
