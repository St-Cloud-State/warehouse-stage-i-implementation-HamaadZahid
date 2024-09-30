﻿public class Product
{
    private String productName;
    private int productId;
    private int quantity;
    private double price;

    // Constructor
    public Product(String productName, int productId, int quantity, double price)
    {
        this.productName = productName;
        this.productId = productId;
        this.quantity = quantity;
        this.price = price;
    }

    // Getter for productName
    public String getProductName()
    {
        return productName;
    }

    // Setter for productName
    public void setProductName(String productName)
    {
        this.productName = productName;
    }

    // Getter for productId
    public int getProductId()
    {
        return productId;
    }

    // Setter for productId
    public void setProductId(int productId)
    {
        this.productId = productId;
    }

    // Getter for quantity
    public int getQuantity()
    {
        return quantity;
    }

    // Setter for quantity
    public void setQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    // Getter for price
    public double getPrice()
    {
        return price;
    }

    // Setter for price
    public void setPrice(double price)
    {
        this.price = price;
    }

    // Method to calculate total value
    public double calculateTotalValue()
    {
        return quantity * price;
    }

    public static void main(String[] args)
    {
        Product productExample = new Product("Laptop", 101, 5, 999.99);
        System.out.println("Total Value: " + productExample.calculateTotalValue());
    }
}
}