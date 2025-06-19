namespace AssetTool
{
    [JsonAsset("GizmoElementTorus")]
    public class UGizmoElementTorus : UGizmoElementCircleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}