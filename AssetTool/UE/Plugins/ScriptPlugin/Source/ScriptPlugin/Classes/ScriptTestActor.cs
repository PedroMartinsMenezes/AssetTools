namespace AssetTool
{
    [JsonAsset("ScriptTestActor")]
    public class AScriptTestActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}