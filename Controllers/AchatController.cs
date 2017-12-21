using System;
using System.Data.SqlClient;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using web.Models;

namespace web.Controllers
{ 
[Route("api/[controller]")]
[EnableCors("AllowSpecificOrigin")]
public class AchatController : Controller
    {
            public AchatController() {}

[HttpGet]
[Route("/api/achat/{id}/{productName}/{price}")]
[EnableCors("AllowSpecificOrigin")]
public string Achat(string productName,string id,string price)

    {
        
        SqlConnection con = new SqlConnection("server=localhost;database=vega;Integrated Security=SSPI");  
            SqlCommand cmd;  
            con.Open();  
            string s="insert into Achat values(@p1,@p2,@p3)";  
            cmd=new SqlCommand(s,con);  
            cmd.Parameters.AddWithValue("@p1",id);  
            cmd.Parameters.AddWithValue("@p2",productName);  
            cmd.Parameters.AddWithValue("@p3",price);  
          
            int i=cmd.ExecuteNonQuery();  
            con.Close();  
          
          return i.ToString();
    }
}
}