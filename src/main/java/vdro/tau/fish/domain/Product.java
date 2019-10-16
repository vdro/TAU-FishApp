package vdro.tau.fish.domain;

public class Product {
    public Product(int Id,
                   String Label,
                   String Name,
                   String Description,
                   int CategoryId,
                   int Quantity,
                   float NetPrice,
                   float GrossPrice,
                   boolean FakeProduct)
    {
        if (Id < 0)
            throw new IllegalArgumentException("Id should be of positive value");
        if (CategoryId < 0)
            throw new IllegalArgumentException("CategoryId should be of positive value");
        if (Quantity < 0)
            throw new IllegalArgumentException("Quantity should be of positive value");
        if (NetPrice < 0)
            throw new IllegalArgumentException("NetPrice should be of positive value");
        if (GrossPrice < 0)
            throw new IllegalArgumentException("GrossPrice should be of positive value");

        this.Id = Id;
        this.Label = Label;
        this.Name = Name;
        this.Description = Description;
        this.CategoryId = CategoryId;
        this.Quantity = Quantity;
        this.NetPrice = NetPrice;
        this.GrossPrice = GrossPrice;
        this.FakeProduct = FakeProduct;
    }

    private int Id;
    private String Label;
    private String Name;
    private String Description;
    private int CategoryId;
    private int Quantity;
    private float NetPrice;
    private float GrossPrice;
    private boolean FakeProduct;

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public String getLabel() {
        return Label;
    }

    public void setLabel(String label) {
        Label = label;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String description) {
        Description = description;
    }

    public int getCategoryId() {
        return CategoryId;
    }

    public void setCategoryId(int categoryId) {
        CategoryId = categoryId;
    }

    public int getQuantity() {
        return Quantity;
    }

    public void setQuantity(int quantity) {
        Quantity = quantity;
    }

    public float getNetPrice() {
        return NetPrice;
    }

    public void setNetPrice(float netPrice) {
        NetPrice = netPrice;
    }

    public float getGrossPrice() {
        return GrossPrice;
    }

    public void setGrossPrice(float grossPrice) {
        GrossPrice = grossPrice;
    }

    public boolean isFakeProduct() {
        return FakeProduct;
    }

    public void setFakeProduct(boolean fakeProduct) {
        FakeProduct = fakeProduct;
    }
}