namespace AssetTool
{
    [JsonAsset("GizmoActor")]
    public class AGizmoActor : AInternalToolFrameworkActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}