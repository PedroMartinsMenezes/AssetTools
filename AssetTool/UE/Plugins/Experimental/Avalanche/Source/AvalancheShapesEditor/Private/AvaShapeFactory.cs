namespace AssetTool
{
    [JsonAsset("AvaShapeFactory")]
    public class UAvaShapeFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}