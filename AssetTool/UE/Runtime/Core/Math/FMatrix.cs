namespace AssetTool
{
    public class FMatrix
    {
        public FPlane XPlane = new();
        public FPlane YPlane = new();
        public FPlane ZPlane = new();
        public FPlane WPlane = new();

        public FMatrix Move(Transfer transfer)
        {
            XPlane.Move(transfer);
            YPlane.Move(transfer);
            ZPlane.Move(transfer);
            WPlane.Move(transfer);
            return this;
        }
    }
}
