namespace AssetTool
{
    [JsonAsset("FunctionalTestLevelScript")]
    public class AFunctionalTestLevelScript : ALevelScriptActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}