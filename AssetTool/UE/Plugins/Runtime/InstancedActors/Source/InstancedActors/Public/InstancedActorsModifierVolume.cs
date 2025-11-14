namespace AssetTool
{
    [JsonAsset("InstancedActorsModifierVolume")]
    public class AInstancedActorsModifierVolume : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InstancedActorsRemovalModifierVolume")]
    public class AInstancedActorsRemovalModifierVolume : AInstancedActorsModifierVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}