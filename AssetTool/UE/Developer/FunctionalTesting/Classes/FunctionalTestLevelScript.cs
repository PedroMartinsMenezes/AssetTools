namespace AssetTool
{
    [JsonAsset("FunctionalTestLevelScript")]
    public class AFunctionalTestLevelScript : ALevelScriptActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}