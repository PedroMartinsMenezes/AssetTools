namespace AssetTool
{
    [JsonAsset("SynthSound")]
    public class USynthSound : USoundWaveProcedural
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SynthComponent")]
    public class USynthComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}