namespace AssetTool
{
    [JsonAsset("AvaTextActorTool")]
    public class UAvaTextActorTool : UAvaInteractiveToolsActorPointToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}