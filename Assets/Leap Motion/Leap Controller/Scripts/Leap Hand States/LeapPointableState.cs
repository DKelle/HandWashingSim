public class LeapPointableState : LeapState{
	
	public LeapPointableState() { }
	
	public LeapPointableState(LeapGameObject obj)
	{
		activeObj = obj;
	}
	
	public override void Enter(HandTypeBase o)
	{
		handController = o;
		if (activeObj)
			handController.SetActiveObject(activeObj);
	}
	
	public override void Execute()
	{
		if (handController.unityHand == null)
			return;
		
		if (handController.activeObj)
		{
			// Update active object
			activeObj.UpdateTransform(handController);
			
			CheckEscape();
		}
	}
}
