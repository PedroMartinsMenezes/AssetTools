namespace AssetTool
{
    [JsonAsset("AvaShapeFactory")]
    public class UAvaShapeFactory : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}