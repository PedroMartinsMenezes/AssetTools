namespace AssetTool
{
    [JsonAsset("SequencerModuleOutlinerScriptingObject")]
    public class USequencerModuleOutlinerScriptingObject : USequencerOutlinerScriptingObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}