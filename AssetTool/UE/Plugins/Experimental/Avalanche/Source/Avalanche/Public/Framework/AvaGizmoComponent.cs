namespace AssetTool
{
    [JsonAsset("AvaGizmoComponent")]
    public class UAvaGizmoComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}