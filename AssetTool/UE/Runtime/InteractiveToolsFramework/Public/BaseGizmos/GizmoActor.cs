namespace AssetTool
{
    [JsonAsset("GizmoActor")]
    public class AGizmoActor : AInternalToolFrameworkActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}