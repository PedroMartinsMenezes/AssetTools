namespace AssetTool
{
    [JsonAsset("GizmoElementBase")]
    public class UGizmoElementBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}