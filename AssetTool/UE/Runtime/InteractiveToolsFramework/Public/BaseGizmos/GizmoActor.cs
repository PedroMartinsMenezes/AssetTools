namespace AssetTool
{
    [JsonAsset("GizmoActor")]
    public class AGizmoActor : AInternalToolFrameworkActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}