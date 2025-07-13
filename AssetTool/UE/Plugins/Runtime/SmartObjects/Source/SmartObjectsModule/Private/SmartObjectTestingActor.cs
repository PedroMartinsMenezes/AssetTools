namespace AssetTool
{
    [JsonAsset("SmartObjectTest")]
    public class USmartObjectTest : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectSimpleQueryTest")]
    public class USmartObjectSimpleQueryTest : USmartObjectTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectTestRenderingComponent")]
    public class USmartObjectTestRenderingComponent : USmartObjectDebugRenderingComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectTestingActor")]
    public class ASmartObjectTestingActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}