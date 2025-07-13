namespace AssetTool
{
    [JsonAsset("InstancedActorsModifierBase")]
    public class UInstancedActorsModifierBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveInstancedActorsModifier")]
    public class URemoveInstancedActorsModifier : UInstancedActorsModifierBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}