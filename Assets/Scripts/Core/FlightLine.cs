using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightLine : MonoBehaviour
{
    bool isBusy = false;

    public bool GetFlightlineBusy() => isBusy;
    public void SetFlightlineBusy(bool isBusy)
    {
        this.isBusy = isBusy;
    }
}
