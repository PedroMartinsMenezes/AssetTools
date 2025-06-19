namespace AssetTool
{
    [JsonAsset("AvaGizmoComponent")]
    public class UAvaGizmoComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}