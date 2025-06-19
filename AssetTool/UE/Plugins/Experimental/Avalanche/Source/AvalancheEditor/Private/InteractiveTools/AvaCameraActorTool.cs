namespace AssetTool
{
    [JsonAsset("AvaCameraActorTool")]
    public class UAvaCameraActorTool : UAvaInteractiveToolsActorTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}