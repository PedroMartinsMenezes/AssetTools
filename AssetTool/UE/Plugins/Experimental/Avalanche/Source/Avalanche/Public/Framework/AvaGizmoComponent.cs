namespace AssetTool
{
    [JsonAsset("AvaGizmoComponent")]
    public class UAvaGizmoComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}