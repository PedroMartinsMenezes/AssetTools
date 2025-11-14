namespace AssetTool
{
    [JsonAsset("AvaEffectorActorTool")]
    public class UAvaEffectorActorTool : UAvaInteractiveToolsActorPointToolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}