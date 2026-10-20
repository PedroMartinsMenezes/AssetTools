namespace AssetTool
{
    public class TPolyBezierSpline<T> : TBSpline<T> where T : ITransferable, new()
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
