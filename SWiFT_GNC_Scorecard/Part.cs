public class Part
{
    public int ID { get; set; }
    public int DeptID { get; set; }
    public int UserID { get; set; }
    public string? Schedule { get; set; }
    public string? OrderNumber { get; set; }
    public string? WALLNUM { get; set; }
    public string? ROOMNUM { get; set; }
    public string? LINNUM { get; set; }
    public decimal PARTQTY { get; set; } 
    public decimal WIDTH { get; set; }
    public string? WIDTHSTR { get; set; }
    public decimal LENGTH { get; set; }
    public string? LENGTHSTR { get; set; }
    public decimal DEPTH { get; set; }
    public string? DEPTHSTR { get; set; }
    public int PARTID { get; set; }
    public string? PARTNAME { get; set; }
    public string? MATERIALID { get; set; }
    public string? MATERIALNAME { get; set; }
    public string? MATLISTNUM { get; set; }
    public string? MATGRAINDEF { get; set; }
    public string? OPTIMIZE { get; set; }
    public string? STOCKPART { get; set; }
    public string? WASTEFACTOR { get; set; }
    public string? MATCOST { get; set; }
    public string? MATCOSTUNIT { get; set; }
    public string? LABORMINUTES { get; set; }
    public string? MATTYPE { get; set; }
    public string? UDF2DEC { get; set; }
    public string? UDF3DEC { get; set; }
    public string? UDF4DEC { get; set; }
    public string? CABNAME { get; set; }
    public string? CABNAMETYPE { get; set; }
    public string? PARTCOMMENT { get; set; }
    public string? PARTBANDCODE { get; set; }
    public string? ROOMNAME { get; set; }
    public string? SECONDPRTPROG { get; set; }
    public string? PRIMARYPRTPROGMIRR { get; set; }
    public string? SECONDPRTPROGMIRR { get; set; }
    public string? PPPBARCODE { get; set; }
    public string? SPPBARCODE { get; set; }
    public string? JOBDESCRIPTION { get; set; }
    public string? INTBANDMAT { get; set; }
    public string? INTBANDCOLOR { get; set; }
    public List<TrackedTimes>? trackedTimes { get; set; }
    public bool isCNC { get; set; }
    public bool isPanelSaw { get; set; }
    public bool isShowing { get; set; }
    public bool isNonShow { get; set; }
    public bool isYellow { get; set; }


}