using System;

namespace MoneyTracking;

public class GetInfo
// this method is used to hold and organize the product's information given by user
{
    public string productCategory {get; set;}
    public string productName {get; set;}
    public int     productPrice{get; set;}
    public GetInfo(string productcategory, string productname, int productprice)
    {
        productCategory=productcategory;
        productName=productname;
        productPrice=productprice;
    }
    
}

