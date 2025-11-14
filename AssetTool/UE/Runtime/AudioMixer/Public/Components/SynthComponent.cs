namespace AssetTool
{
    [JsonAsset("SynthSound")]
    public class USynthSound : USoundWaveProcedural
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SynthComponent")]
    public class USynthComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}