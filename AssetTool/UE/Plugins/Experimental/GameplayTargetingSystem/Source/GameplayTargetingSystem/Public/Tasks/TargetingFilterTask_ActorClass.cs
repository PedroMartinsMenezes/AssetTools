namespace AssetTool
{
    [JsonAsset("TargetingFilterTask_ActorClass")]
    public class UTargetingFilterTask_ActorClass : UTargetingFilterTask_BasicFilterTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}