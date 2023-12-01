using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebShooter : MonoBehaviour
{
    [SerializeField] private Sprite webPieceSprite;
    private Vector3 direction;
    Vector3 finalPos;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            finalPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            finalPos = new Vector3(finalPos.x, finalPos.y, 0);
            direction = finalPos - transform.position;
            ShootWeb();
        }
    }

    void ShootWeb()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, Mathf.Infinity, LayerMask.GetMask("CanHook"));

        if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);
            GenerateWeb(hit.point);
        }
    }
    void GenerateWeb(Vector3 contactPoint)
    {
        float distance = (contactPoint - transform.position).magnitude;

        int numberOfWebPieces = Mathf.RoundToInt(distance / 0.5f) + 1;

        for (int i = 0; i < numberOfWebPieces; i++)
        {
            GameObject webPiece = new GameObject();
            webPiece.AddComponent<SpriteRenderer>();
            webPiece.GetComponent<SpriteRenderer>().sprite = webPieceSprite;
            webPiece.transform.localScale = new Vector3(0.2f, 0.5f, 1);
            webPiece.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan((contactPoint - transform.position).x / (contactPoint - transform.position).y));
            webPiece.transform.Translate(new Vector3(contactPoint.x, contactPoint.y - i * 0.5f, 0));
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, finalPos);
    }

}
