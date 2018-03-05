

function RandomlyTeleport()
    {
        gameObject.transform.position = new Vector3(
            GetRandomCoordinate(), Random.Range(0.5f, 2), GetRandomCoordinate());
    }

    function GetRandomCoordinate()
    {
        var coordinate = Random.Range(-7, 7);
        while (coordinate > -1.5 && coordinate < 1.5)
        {
            coordinate = Random.Range(-5, 5);
        }

        return coordinate; 
    }