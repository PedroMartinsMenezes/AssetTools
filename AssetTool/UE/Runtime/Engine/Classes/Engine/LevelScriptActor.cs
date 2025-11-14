namespace AssetTool
{
    [JsonAsset("LevelScriptActor")]
    public class ALevelScriptActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}