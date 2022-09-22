using Microsoft.EntityFrameworkCore;


    public class OnyxDBContext : DbContext 
{ 
    public OnyxDBContext(DbContextOptions<OnyxDBContext> options): base(options)
    {
    
    }

    public DbSet<Part> Parts { get; set; }
    public DbSet<YellowPart> YellowParts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Part>().HasData(
             
        
            new Part
            {
                ID = 6825,
                DeptID = 2,
                UserID = 7777,
                Schedule = "SCHEDULE 00-01",
                OrderNumber = "21009716",
                WALLNUM = "0",
                ROOMNUM = "1",
                LINNUM = "1",
                PARTQTY = 2,
                WIDTH = 10.8438M,
                WIDTHSTR = "10 19/32",
                LENGTH = 34.6250M,
                LENGTHSTR = "34 3/8",
                DEPTH = 1.0000M,
                DEPTHSTR = "0.75",
                PARTID = 15,
                PARTNAME = "Adjustable Shelf",
                MATERIALID = "1841",
                MATERIALNAME = "0750 CL BIRCH ADJSH PB",
                MATLISTNUM = "1",
                MATGRAINDEF = "NULL",
                OPTIMIZE = "NULL",
                STOCKPART = "NULL",
                WASTEFACTOR = "NULL",
                MATCOST = "NULL",
                MATCOSTUNIT = "NULL",
                LABORMINUTES = "NULL",
                MATTYPE = "NULL",
                UDF2DEC = "NULL",
                UDF3DEC = "NULL",
                UDF4DEC = "NULL",
                CABNAME = "W-3636BD",
                CABNAMETYPE = "W",
                PARTCOMMENT = "NULL",
                PARTBANDCODE = "NULL",
                ROOMNAME = "NULL",
                SECONDPRTPROG = "NULL",
                PRIMARYPRTPROGMIRR = "NULL",
                SECONDPRTPROGMIRR = "NULL",
                PPPBARCODE = "NULL",
                SPPBARCODE = "NULL",
                JOBDESCRIPTION = "NULL",
                INTBANDMAT = "NULL",
                INTBANDCOLOR = "NULL",
                isCNC = true,
                isPanelSaw = false,
                isShowing = false,
                isNonShow = false,
                isYellow = false,


            });
    }
}
