namespace AssetTool
{
    [JsonAsset("AvaCameraPriorityModifier")]
    public class UAvaCameraPriorityModifier : UActorModifierCoreBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}