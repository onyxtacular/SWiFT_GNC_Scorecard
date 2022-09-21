public class YellowPart
{
    public int ID { get; set; }
    public bool isCatchUp { get; set; }
    public bool isRush { get; set; }
    public bool isSuperHot { get; set; }
    public int FmDeptID { get; set; }
    public int ToDeptID { get; set; }
    public int UserID { get; set; }
    public string OrderNumber { get; set; }
    public string Schedule { get; set; }
    public string LineNumber { get; set; }
    public bool isDoor { get; set; }
    public bool isBoxDrawer { get; set; }
    public bool isFrontDrawer { get; set; }
    public bool isFrame { get; set; }
    public bool isShowing { get; set; }
    public bool isNonShowing { get; set; }
    public bool MyProperty { get; set; }

    public decimal PARTQTY { get; set; }
    public decimal WIDTH { get; set; }
    public string WIDTHSTR { get; set; }
    public decimal LENGTH { get; set; }
    public string LENGTHSTR { get; set; }
    public decimal DEPTH { get; set; }
    public string DEPTHSTR { get; set; }
    public int PARTID { get; set; }
    public bool isSide { get; set; }
    public bool isBack { get; set; }
    public bool isFloor { get; set; }
    public bool isShelf { get; set; }
    public bool isSpecialty { get; set; }
    public bool isMaterialDefect { get; set; }
    public bool isSandingDefect { get; set; }
    public bool isOrderProblem  { get; set; }
    public bool isDrawingProplem  { get; set; }
    public bool isFinishPropblem { get; set; }
    public bool isCutlistProblem  { get; set; }
    public bool isProcedureError  { get; set; }
    public string Comment { get; set; }
    public List<TrackedTimes> yellowTrackTimes { get; set; }
    public int DispenseID { get; set; }
    public int DispenseUserID  { get; set; }
    public bool isReuse  { get; set; }
    public bool isRecvCredit { get; set; }
    public bool isScrap  { get; set; }
    public string DispComment { get; set; }

}
