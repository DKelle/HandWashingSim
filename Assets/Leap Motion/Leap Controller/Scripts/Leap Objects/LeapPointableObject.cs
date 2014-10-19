using Leap;

public class LeapPointableObject : LeapBasicObject{
	
	/*
	public override LeapState Activate(HandTypeBase h)
	{
		base.Activate(h);
		return new LeapPointableState(this);
	}
	
	public override void UpdateTransform (HandTypeBase t)
	{
		base.UpdateTransform (t);
		UpdatePointTransform(t);
	}
	
	void UpdatePointTransform(HandTypeBase t)
	{
		Collider o = collider;
		
		Vector3 handOffset = new Vector3();
		Vector3 grabOffsetPos = new Vector3();
		bool fingerFound = false;
		
		// Uses Index Finger to aim
		if (owner.unityHand.unityFingers.ContainsKey(FINGERS.INDEX))
		{
			fingerFound = true;
		}
		
		o.transform.position = owner.transform.position + handOffset - grabOffsetPos;
		
		Vector3 tipPosition;
		
		if (fingerFound)
		{
			tipPosition =
				owner.unityHand.unityFingers[FINGERS.INDEX].transform.position;
		}
		else
		{
			tipPosition =
				owner.unityHand.hand.Fingers.Frontmost.TipPosition.ToUnityTranslated();
		}
		
		//Look at Finger
		o.transform.LookAt(tipPosition, owner.unityHand.transform.up); // Add finger rotation
	}

*/
	
}