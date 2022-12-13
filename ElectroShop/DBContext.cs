namespace ElectroShop
{
    public static class DBContext
    {
        static ElectroShopEntities db { get; set; }
        public static ElectroShopEntities GetDBContext()
        {
            if (db == null) return db = new ElectroShopEntities();
            else return db;
        }
    }
}
