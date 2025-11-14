namespace AssetTool
{
    [JsonAsset("ActorActionUtility")]
    public class UActorActionUtility : UEditorUtilityObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}