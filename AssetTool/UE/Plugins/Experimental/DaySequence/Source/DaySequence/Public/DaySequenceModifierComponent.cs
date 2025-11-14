namespace AssetTool
{
    [JsonAsset("DaySequenceModifierEasingFunction")]
    public class UDaySequenceModifierEasingFunction : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DaySequenceModifierComponent")]
    public class UDaySequenceModifierComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}