namespace AssetTool
{
    [JsonAsset("GameplayTasksComponent")]
    public class UGameplayTasksComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}