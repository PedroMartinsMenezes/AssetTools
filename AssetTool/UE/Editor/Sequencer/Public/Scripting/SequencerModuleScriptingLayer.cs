namespace AssetTool
{
    [JsonAsset("SequencerModuleScriptingLayer")]
    public class USequencerModuleScriptingLayer : USequencerScriptingLayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}