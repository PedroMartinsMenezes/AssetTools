namespace AssetTool
{
    [JsonAsset("InstancedActorsModifierVolume")]
    public class AInstancedActorsModifierVolume : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InstancedActorsRemovalModifierVolume")]
    public class AInstancedActorsRemovalModifierVolume : AInstancedActorsModifierVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}