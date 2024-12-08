namespace AssetTool
{
    [JsonAsset("LevelScriptActor")]
    public class ALevelScriptActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}