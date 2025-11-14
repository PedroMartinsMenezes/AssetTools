namespace AssetTool
{
    [JsonAsset("AvaShapeFactory")]
    public class UAvaShapeFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}