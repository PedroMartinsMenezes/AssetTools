namespace AssetTool
{
    [JsonAsset("LearningAgentsActionSchema")]
    public class ULearningAgentsActionSchema : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LearningAgentsActionObject")]
    public class ULearningAgentsActionObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LearningAgentsActions")]
    public class ULearningAgentsActions : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}