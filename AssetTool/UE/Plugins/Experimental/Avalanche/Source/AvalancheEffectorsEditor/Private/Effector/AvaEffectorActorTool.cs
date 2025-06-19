namespace AssetTool
{
    [JsonAsset("AvaEffectorActorTool")]
    public class UAvaEffectorActorTool : UAvaInteractiveToolsActorPointToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}