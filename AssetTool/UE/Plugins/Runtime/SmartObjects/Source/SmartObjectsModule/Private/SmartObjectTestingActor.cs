namespace AssetTool
{
    [JsonAsset("SmartObjectTest")]
    public class USmartObjectTest : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectSimpleQueryTest")]
    public class USmartObjectSimpleQueryTest : USmartObjectTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectTestRenderingComponent")]
    public class USmartObjectTestRenderingComponent : USmartObjectDebugRenderingComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectTestingActor")]
    public class ASmartObjectTestingActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}