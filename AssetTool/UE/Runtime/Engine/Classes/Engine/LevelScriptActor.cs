namespace AssetTool
{
    [JsonAsset("LevelScriptActor")]
    public class ALevelScriptActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}