namespace AssetTool
{
    [JsonAsset("GizmoElementBase")]
    public class UGizmoElementBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}