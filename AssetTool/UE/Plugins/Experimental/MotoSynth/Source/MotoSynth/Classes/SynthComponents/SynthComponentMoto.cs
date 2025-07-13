namespace AssetTool
{
    [JsonAsset("SynthComponentMoto")]
    public class USynthComponentMoto : USynthComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}