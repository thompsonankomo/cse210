class Program
{


    static void Main(string[] args)
    {
        ElectricalDepartment eDepartment = new ElectricalDepartment();
        eDepartment.setName = ("Asakhe Electrical Department");
        eDepartment.customerDetails = ("Mandla Moyor");
        eDepartment.addProduct();

        TilesDepartment tDepartment = new TilesDepartment();
        tDepartment.setName = ("Asakhe Tiling Department");
        tDepartment.setPriceRate = (13);

        GardeningDepartment gDepartment = new GardeningDepartment();
        gDepartment.setPriceRate = ("12");
        gDepartment.addProduct();


        PrecisionDepartment pDepartment = new PrecisionDepartment();
        pDepartment.setPriceRate = (14);
        pDepartment.setCustomerDetails = ("Mnadla Sibanda");

        RoofingDepartment rDepartment = new RoofingDepartment();
        rDepartment.setPriceRate = (12);
        rDepartment.setCustomerPhone = (0771734760);

        PaintDepartment NewPaintDepartment = new PaintDepartment();
        NewPaintDepartment.setId = ("123455");
        NewPaintDepartment.setName = ("Asakhe Paints");

        FittingDepartment fDepartment = new FittingDepartment();
        fDepartment.SetName =("Asakhe Fitting Department");
        fDepartment.setPriceRate = (12);

        BoardsDepartment bDepartment = new BoardsDepartment();
        bDepartment.setName = ("Asakhe Boards Department");
        bDepartment.setPriceRate = (14);

}

    
}

