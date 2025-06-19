namespace AssetTool
{
    [JsonAsset("FunctionalTestLevelScript")]
    public class AFunctionalTestLevelScript : ALevelScriptActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}