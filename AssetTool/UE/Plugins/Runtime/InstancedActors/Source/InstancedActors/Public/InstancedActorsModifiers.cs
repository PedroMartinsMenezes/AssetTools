namespace AssetTool
{
    [JsonAsset("InstancedActorsModifierBase")]
    public class UInstancedActorsModifierBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveInstancedActorsModifier")]
    public class URemoveInstancedActorsModifier : UInstancedActorsModifierBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}