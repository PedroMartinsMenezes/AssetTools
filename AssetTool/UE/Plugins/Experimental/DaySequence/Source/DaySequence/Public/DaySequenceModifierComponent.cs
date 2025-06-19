namespace AssetTool
{
    [JsonAsset("DaySequenceModifierEasingFunction")]
    public class UDaySequenceModifierEasingFunction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DaySequenceModifierComponent")]
    public class UDaySequenceModifierComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}